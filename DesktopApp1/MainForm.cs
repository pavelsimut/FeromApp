using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace FeromApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cbActionPicker.Items.Add("Salveaza");
            cbActionPicker.Items.Add("Update");
            cbActionPicker.Items.Add("Delete");
            cbActionPicker.SelectedIndex = 0;
        }

        private void ActionBtn_Click(object sender, EventArgs e)
        {
            if (cbActionPicker.Text == "Delete")
            {
                HandleDelete();
            }
            if (cbActionPicker.Text == "Update")
            {
                HandleUpdate();
            }
            if (cbActionPicker.Text == "Salveaza")
            {
                HandleAdd();
            }
        }

        private void HandleAdd()
        {
            var piece = new Piece
            {
                DrawCode = DrawCodeID.Text,
                UnitaryPrice = Utils.TryParseFloat(tbUnitaryPrice.Text),
                StockAmount = int.Parse(tbStockNumber.Text)
            };

            piece.NovaPrice = Utils.TryParseFloat(tbNovaPrice.Text);

            Utils.AppendObject(@"Pieces.txt", piece);
            Utils.AppendObject(@"OperationHistory.txt", new OperationHistory(piece, "ADD"));

            MessageBox.Show("A fost salvat cu succes");

        }

        private void HandleUpdate()
        {
            var pieces = Utils.ReadFromFile<Piece>("Pieces.txt");

            var toUpdate = int.TryParse(DrawCodeID.Text, out int index) && index < pieces.Count
                ? pieces[index]
                : pieces.Find(p => p.DrawCode == DrawCodeID.Text);

            if (toUpdate == null)
            {
                MessageBox.Show("Update failed!");
                return;
            }

            toUpdate.SetFromUI(tbUnitaryPrice, tbStockNumber, tbNovaPrice);


            Utils.AppendObject(
                "OperationHistory.txt", 
                new OperationHistory(toUpdate, "UPDATE")
            );

            Utils.WriteArray(@"Pieces.txt", pieces);

            MessageBox.Show("Update succesfull!");

        }

        private void HandleDelete()
        {
            var pieces = Utils.ReadFromFile<Piece>("Pieces.txt");

            var toDelete = int.TryParse(DrawCodeID.Text, out int index) && index < pieces.Count
                ? pieces[index]
                : pieces.Find(p => p.DrawCode == DrawCodeID.Text);

            if (toDelete == null)
            {
                MessageBox.Show("Delete failed!");
                return;
            }

            pieces.Remove(toDelete);

            Utils.AppendObject(
                "OperationHistory.txt",
                new OperationHistory(toDelete, "DELETE")
            );

            Utils.WriteArray(@"Pieces.txt", pieces);

            MessageBox.Show("Delete succesfull!");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("ID ");
            dataTable.Columns.Add("      COD DESEN           ");
            dataTable.Columns.Add("      PRET UNITAR         ");
            dataTable.Columns.Add("      NR. ÎN STOC         ");
            dataTable.Columns.Add("      PRET NOVA           ");

            Utils.ReadFromFile<Piece>("Pieces.txt").Select((piece, i) => dataTable.Rows.Add(
                    i,
                    piece.DrawCode,
                    piece.UnitaryPrice,
                    piece.StockAmount,
                    piece.NovaPrice
                )
            ).ToList();

            dgv.DataSource = dataTable;
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            var dt = new DataTable();
            dt.Columns.Add("      TIP                 ");
            dt.Columns.Add("      COD DESEN           ");
            dt.Columns.Add("      PRET UNITAR         ");
            dt.Columns.Add("      NR. ÎN STOC         ");
            dt.Columns.Add("      PRET NOVA           ");
            dt.Columns.Add("      DATE                ");
            foreach (var op in Utils.ReadFromFile<OperationHistory>("OperationHistory.txt"))
            {
                dt.Rows.Add(
                    op.Type,
                    op.DrawCode,
                    op.UnitaryPrice,
                    op.StockAmount,
                    op.NovaPrice,
                    op.CurrentTime
                 );
            }

            dgv.DataSource = dt;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbActionPicker.Text == "Salveaza")
                btnAction.Text = "Salveaza";
            else if (cbActionPicker.Text == "Update")
                btnAction.Text = "Update";
            else if (cbActionPicker.Text == "Delete")
                btnAction.Text = "Delete";
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        

            var bmp = new Bitmap(dgv.Width, dgv.Height);

            dgv.DrawToBitmap(
                bmp,
                new Rectangle(0, 0, dgv.Width, dgv.Height)
            );
            bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);

            e.Graphics.DrawImage(bmp, e.MarginBounds);
           
        }
    }
}
