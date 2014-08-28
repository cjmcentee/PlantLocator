using ExcelLibrary.SpreadSheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantLocator
{
    public class CartInfo
    {
        //public bool Selected { get; set; }

        public int ConveyorGroup { get; set; }
        public const string CONVEYOR_GROUP_LABEL = "Conveyor Group";

        public int ConveyorBelt { get; set; }
        public const string CONVEYOR_BELT_LABEL = "Conveyor Belt";

        public int CartPosition { get; set; }
        public const string CART_POSITION_LABEL = "Cart Position";

        public string CarTag { get; set; }
        public const string CAR_TAG_LABEL = "Car Tag";
        
        public string PlantBarcode { get; set;}
        public const string PLANT_BARCODE_LABEL = "Plant Barcode";

        public const int NUMBER_FIELDS = 6;

        public CartInfo()
        {
            //Selected = false;
        }

        public override string ToString()
        {
            return ConveyorGroup + "/" + ConveyorBelt + "/" + CartPosition
                + ": " + CarTag + " -- " + PlantBarcode;
        }

        public static List<CartInfo> SortByFieldIndex(List<CartInfo> carts, int columnIndex)
        {
            IEnumerable<CartInfo> sortedCarts = null;

            /*if (columnIndex == 0)
                sortedCarts = from cart in carts orderby cart.Selected ascending select cart;
            else */if (columnIndex == 0)
                sortedCarts = from cart in carts orderby cart.ConveyorGroup ascending select cart;
            else if (columnIndex == 1)
                sortedCarts = from cart in carts orderby cart.ConveyorBelt ascending select cart;
            else if (columnIndex == 2)
                sortedCarts = from cart in carts orderby cart.CartPosition ascending select cart;
            else if (columnIndex == 3)
                sortedCarts = from cart in carts orderby cart.CarTag ascending select cart;
            else if (columnIndex == 4)
                sortedCarts = from cart in carts orderby cart.PlantBarcode ascending select cart;
            else
                throw new InvalidOperationException("CartInfo doesn't have more than 5 fields.");

            return sortedCarts.ToList();
        }

        public List<Cell> ExcelRow()
        {
            List<Cell> cells = new List<Cell>();
            cells.Add(new Cell(ConveyorGroup));
            cells.Add(new Cell(ConveyorBelt));
            cells.Add(new Cell(CartPosition));
            cells.Add(new Cell(CarTag));
            cells.Add(new Cell(PlantBarcode));
            return cells;
        }

        public static List<Cell> ExcelHeader()
        {
            List<Cell> cells = new List<Cell>();
            cells.Add(new Cell(CONVEYOR_GROUP_LABEL));
            cells.Add(new Cell(CONVEYOR_BELT_LABEL));
            cells.Add(new Cell(CART_POSITION_LABEL));
            cells.Add(new Cell(CAR_TAG_LABEL));
            cells.Add(new Cell(PLANT_BARCODE_LABEL));
            return cells;
        }
    }
}
