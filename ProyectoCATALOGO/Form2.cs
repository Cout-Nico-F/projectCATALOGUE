using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCATALOGO
{
  public partial class Form2 : Form
  {
    public Form2()
    {
      InitializeComponent();
    }

    private void iceCreamsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
    {
      this.Validate();
      this.iceCreamsBindingSource.EndEdit();
      this.tableAdapterManager.UpdateAll(this.dataSet_IceCreamsCatalogue);

    }

    private void Form2_Load(object sender, EventArgs e)
    {
      // TODO: This line of code loads data into the 'dataSet_IceCreamsCatalogue.IceCreams' table. You can move, or remove it, as needed.
      this.iceCreamsTableAdapter.Fill(this.dataSet_IceCreamsCatalogue.IceCreams);

    }
  }
}
