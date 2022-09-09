using MLClassifier;

namespace Ucitavanje_validacija_slike
{
    public partial class ValidacijaForm : Form
    {
        OpenFileDialog ucitajSliku = new OpenFileDialog();
 
        public ValidacijaForm()
        {
            InitializeComponent();
            prikazSlikePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
        }

        public void ucitajButton_Click(object sender, EventArgs e)
        {            
            ucitajSliku.Title = "Slika";
            ucitajSliku.Filter = "slika(*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg"; 
            ucitajSliku.ShowDialog();
            prikazSlikePicBox.Image = new Bitmap(ucitajSliku.FileName);
        }

        public void validirajButton_Click(object sender, EventArgs e)
        {
            var result = Classifier.Classify(ucitajSliku.FileName);
            rezultatOutput.Text = "Rezultat klasifikacije je:\n"  + result.ToString();
        }
    }
}