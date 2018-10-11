using System;

namespace FeromApp
{
    public class OperationHistory : Piece
    {
        public string CurrentTime { get; set; }
        public string Type { get; set; }

        public OperationHistory() { }

        public OperationHistory(Piece p, string type)
        {
            DrawCode = p.DrawCode;
            UnitaryPrice = p.UnitaryPrice;
            StockAmount = p.StockAmount;
            NovaPrice = p.NovaPrice;
            CurrentTime = DateTime.Now.ToString("dd/MM/yyyy");
            Type = type;
        }
    }
}
