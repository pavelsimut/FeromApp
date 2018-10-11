using System.Windows.Forms;

namespace FeromApp
{
    public class Piece
    {
        public string DrawCode { get; set; }
        public float UnitaryPrice { get; set; }
        public int StockAmount { get; set; }
        public float NovaPrice { get; set; }
        public void SetFromUI(TextBox unitaryPrice, TextBox stockAmount, TextBox novaPrice)
        {
            UnitaryPrice = Utils.TryParseFloat(unitaryPrice.Text);
            StockAmount = Utils.TryParseInt(stockAmount.Text);
            NovaPrice = Utils.TryParseFloat(novaPrice.Text);
        }
    }
}
