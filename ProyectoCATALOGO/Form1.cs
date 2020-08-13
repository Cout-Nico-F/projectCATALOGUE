using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCATALOGO
{
  
  public partial class Catalogo : Form
  {
    SortedList<string, string> CustomList = new SortedList<string, string>();
    private Dictionary<string, string> descriptions = new Dictionary<string, string>();
    string actualIceCreamTag;
    public Catalogo()
    {
      InitializeComponent();
      InitializeDescriptions(descriptions);
      Environment.CurrentDirectory = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "Images");
      //MessageBox.Show(Environment.CurrentDirectory);
      InitializeCustomImageList(CustomList);
      img_IceCream.Image = Image.FromFile(CustomList.First().Value);
      img_IceCream.Tag = CustomList.First().Key;
    }

    private void btn_next_Click(object sender, EventArgs e)
    {
      img_IceCream.Image = null;
      img_IceCream.Image = System.Drawing.Image.FromFile(NextIceCream());
      //img_IceCream.Tag = GetActualIceCream();
      img_IceCream.Tag = actualIceCreamTag;
    }

    private void btn_previous_Click(object sender, EventArgs e)
    {
      img_IceCream.Image = null;
      string previousOne = PreviousIceCream();
      if (previousOne.Equals("ERROR"))
      {
        MessageBox.Show("ERROR 202 CALLED BY FORM1.CS IN PREVIOUSICECREAM Value not found by foreach");
      }
      else
      {
        img_IceCream.Tag = actualIceCreamTag;
        img_IceCream.Image = System.Drawing.Image.FromFile(previousOne);
      }

    }

    private void InitializeCustomImageList (SortedList<string, string> CustomList)
    {
      
      CustomList.Add("chocobomb", @".\chocobomb.png");
      CustomList.Add("tricolor", @"C:.\tricolor.png");
      CustomList.Add("magnuscream", @".\magnuscream.png");
      CustomList.Add("chococherry", @".\chococherry.png");
    }

    private string NextIceCream ()
    {
      bool find = false;
      string lastOne;
      foreach (KeyValuePair<string, string> pair in CustomList)
      {
        if (find)
        {
          actualIceCreamTag = pair.Key;
          return pair.Value;
        }
        if (pair.Key == img_IceCream.Tag.ToString())
        {
          find = true;
          lastOne = pair.Key;
        }
      }
      actualIceCreamTag = "chocobomb";
      img_IceCream.Tag = "chocobomb";
     return CustomList["chocobomb"];
    }

    private string PreviousIceCream()
    {
      string lastOne_value = CustomList.Last().Value;
      string lastOne_key = CustomList.Last().Key;
      foreach (KeyValuePair<string, string> pair in CustomList)
      {
        if (CustomList.First().Key == pair.Key)
        {
          if (pair.Key.Equals(img_IceCream.Tag.ToString()))
          {
            actualIceCreamTag = lastOne_key;
            return lastOne_value;
          }
          else
          {
            lastOne_key = pair.Key;
            lastOne_value = pair.Value;
          }
        }

        if (pair.Key == img_IceCream.Tag.ToString())
        {
          actualIceCreamTag = lastOne_key;
          return lastOne_value;
        }
        else
        {
          lastOne_value = pair.Value;
          lastOne_key = pair.Key;
        }
      }
      return "ERROR";
    }

    private void btn_description_Click(object sender, EventArgs e)
    {
      foreach (KeyValuePair<string, string> pair in CustomList)
      {
        if (pair.Key.Equals(img_IceCream.Tag.ToString()))
        {
          ShowDescription(pair.Key);
        }
      }
    }

        
   
    private void ShowDescription(string key)
    {

      switch (key)
      {
        case "chocobomb":
          MessageBox.Show(descriptions["chocobomb"]);
          break;
        case "magnuscream":
          MessageBox.Show(descriptions["magnuscream"]);
          break;
        case "tricolor":
            MessageBox.Show(descriptions["tricolor"]);
          break;
        case "chococherry":
            MessageBox.Show(descriptions["chococherry"]);
          break;
        default:
          MessageBox.Show("ERROR 303 unknown key on ShowDescription() parameter (string)");
          break;
      }
    }


    private void InitializeDescriptions(Dictionary<string, string> list)
    {
      list.Add("chocobomb", "ChocoBomb: \nDeliciosa copa de crema helada de chocolate belga con leche y crocante de almendras . Cubierto de salsa de chocolate amargo, acompañado de una oblea rellena de crema de cacao");
      list.Add("tricolor", "Tricolor: \nIdeal para cuando no podes decidirte por un solo sabor, Crema de vainilla, frutilla con frutos rojos y chocolate clasico, acompañados de almibar y obleas");
      list.Add("magnuscream", "MagnusCream: \nTodo el poder de las cremas en un mismo postre, base de crema chantilly cubierto de crema de castañas y cacao, acompañado de crocante de frutos secos");
      list.Add("chococherry", "ChocoCherry: \nPerfecta combinacion de chocolate intenso fabricado con cacao de ecuador, crema helada de vainilla y la frescura especial de la crema de cerezas, acompañado de cerezas acarameladas y crema chantilly");
    }
    /*
    private void GetActualIceCream ()
    {
      foreach (KeyValuePair<string, string> pair in CustomList)
      {
        if (pair.Key == img_IceCream.Image)
        {

        }
      }
    }*/
  }
}
