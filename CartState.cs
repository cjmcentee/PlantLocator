using ExcelLibrary.SpreadSheet;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace PlantLocator
{
    public class CartState
    {
        public List<CartInfo> carts;
        public DateTime? time;

        protected CartState()
        {
        }

        public CartState(DateTime? time, List<CartInfo> carts)
        {
            this.carts = carts;
            this.time = time;
        }

        public Worksheet ExportToExcel()
        {
            Worksheet cartSystemSheet = new Worksheet("Phenotyper Plant Organization");

            cartSystemSheet.Cells.ColumnWidth[0, CartInfo.NUMBER_FIELDS] = 4500;

            int topRowToWrite = 1;
            topRowToWrite = WriteSystemDate(cartSystemSheet, topRowToWrite);
            topRowToWrite = WriteExportDate(cartSystemSheet, topRowToWrite);
            topRowToWrite = WriteBlankLines(cartSystemSheet, 2, topRowToWrite);
            topRowToWrite = WriteTable(cartSystemSheet, topRowToWrite);

            return cartSystemSheet;
        }

        private int WriteTable(Worksheet worksheet, int zeroRow)
        {
            int row = zeroRow;
            List<Cell> cartHeader = CartInfo.ExcelHeader();
            row = AddRow(worksheet, cartHeader, zeroRow);

            for (int i = 0; i < carts.Count; i++) {
                CartInfo cart = carts[i];

                List<Cell> cartCells = cart.ExcelRow();
                row += 1;
                AddRow(worksheet, cartCells, row);
            }

            return row;
        }

        private int AddRow(Worksheet worksheet, List<Cell> cells, int row)
        {
            for (int column = 0; column < cells.Count; column++) {
                Cell cell = cells[column];
                worksheet.Cells[row, column] = cell;
            }

            return row + 1;
        }

        private int WriteBlankLines(Worksheet worksheet, int numberBlankLines, int zeroRow)
        {
            return zeroRow + numberBlankLines;
        }

        private int WriteExportDate(Worksheet worksheet, int zeroRow)
        {
            return WriteDate(worksheet, "File Exported on", DateTime.Now, zeroRow);
        }

        private int WriteSystemDate(Worksheet worksheet, int zeroRow)
        {
            return WriteDate(worksheet, "System Updated on", this.time, zeroRow);
        }

        private int WriteDate(Worksheet worksheet, String label, DateTime? date, int zeroRow)
        {
            worksheet.Cells[zeroRow, 0] = new Cell(label);

            Cell dateCell = new Cell("");
            if (date.HasValue)
                dateCell.Value = date.Value.ToString();
            else
                dateCell.Value = "Date not Recorded";
            worksheet.Cells[zeroRow, 1] = dateCell;

            return zeroRow + 1;
        }

        public static CartState Parse(DirectoryInfo directory)
        {
            CartState state = new CartState();
            state.carts = Parse(directory.StateFiles());

            try {
                state.time = DateTime.ParseExact(directory.Name, "MMddyy", null);
            }
            catch (Exception e) {
                state.time = new Nullable<DateTime>();
            }

            return state;
        }

        public static List<CartInfo> Parse(IEnumerable<FileInfo> stateFiles)
        {
            List<CartInfo> carts = new List<CartInfo>();

            foreach (FileInfo stateFile in stateFiles)
                carts.AddRange(Parse(stateFile));

            return carts;
        }

        public static List<CartInfo> Parse(FileInfo stateFile)
        {
            StreamReader state = new StreamReader(stateFile.FullName);

            List<CartInfo> carts = new List<CartInfo>();

            Tuple<int, int> conveyorInfo = GetConveyorBeltInfo(stateFile);
            int group = conveyorInfo.Item1;
            int belt = conveyorInfo.Item2;
            int numberCarts = 0;

            while (!state.EndOfStream) {
                string[] cartValues = state.ReadLine().Split(';');

                if (cartValues.Count() != 3)
                    continue;
                else {
                    CartInfo cart = new CartInfo();
                    cart.CarTag = cartValues[0];
                    cart.PlantBarcode = cartValues[2];
                    cart.ConveyorGroup = group;
                    cart.ConveyorBelt = belt;
                    cart.CartPosition = numberCarts;
                    carts.Add(cart);

                    numberCarts++;
                }
            }

            return carts;
        }

        public static Tuple<int, int> GetConveyorBeltInfo(FileInfo stateFile)
        {
            Regex StateFilePattern = new Regex(@"conveyor\.safedomains\.Lane(\d)_(\d)\.state");

            Match conveyorMatch = StateFilePattern.Match(stateFile.Name);

            if (conveyorMatch.Success) {
                GroupCollection conveyorInfo = conveyorMatch.Groups;
                int group = Convert.ToInt32(conveyorInfo[1].Value);
                int belt = Convert.ToInt32(conveyorInfo[2].Value);

                return new Tuple<int, int>(group, belt);
            }

            else
                return new Tuple<int, int>(-1, -1);
        }
    }
}
