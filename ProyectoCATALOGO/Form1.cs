using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    string actualIceCreamTag;
    public Catalogo()
    {
      InitializeComponent();
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
      CustomList.Add("chocobomb", @"C:\chocobomb.png");
      CustomList.Add("tricolor", @"C:\tricolor.png");
      //CustomList.Add("magnuscream", @"C:\magnuscream.png");
      CustomList.Add("chococherry", @"C:\chococherry.png");
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
