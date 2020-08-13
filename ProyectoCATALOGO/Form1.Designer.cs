namespace ProyectoCATALOGO
{
  partial class Catalogo
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catalogo));
      this.btn_recipe = new System.Windows.Forms.Button();
      this.btn_description = new System.Windows.Forms.Button();
      this.btn_previous = new System.Windows.Forms.Button();
      this.btn_next = new System.Windows.Forms.Button();
      this.img_IceCream = new System.Windows.Forms.PictureBox();
      this.btn_PopupDescription = new System.Windows.Forms.Button();
      this.btn_Database = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.img_IceCream)).BeginInit();
      this.SuspendLayout();
      // 
      // btn_recipe
      // 
      this.btn_recipe.BackgroundImage = global::ProyectoCATALOGO.Properties.Resources.fondovacio;
      this.btn_recipe.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn_recipe.FlatAppearance.BorderSize = 0;
      this.btn_recipe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btn_recipe.Image = ((System.Drawing.Image)(resources.GetObject("btn_recipe.Image")));
      this.btn_recipe.ImageAlign = System.Drawing.ContentAlignment.TopRight;
      this.btn_recipe.Location = new System.Drawing.Point(517, 646);
      this.btn_recipe.Name = "btn_recipe";
      this.btn_recipe.Size = new System.Drawing.Size(193, 76);
      this.btn_recipe.TabIndex = 4;
      this.btn_recipe.UseVisualStyleBackColor = true;
      // 
      // btn_description
      // 
      this.btn_description.BackgroundImage = global::ProyectoCATALOGO.Properties.Resources.fondovacio;
      this.btn_description.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn_description.FlatAppearance.BorderSize = 0;
      this.btn_description.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btn_description.Image = ((System.Drawing.Image)(resources.GetObject("btn_description.Image")));
      this.btn_description.ImageAlign = System.Drawing.ContentAlignment.TopRight;
      this.btn_description.Location = new System.Drawing.Point(51, 639);
      this.btn_description.Name = "btn_description";
      this.btn_description.Size = new System.Drawing.Size(327, 90);
      this.btn_description.TabIndex = 3;
      this.btn_description.UseVisualStyleBackColor = true;
      this.btn_description.Click += new System.EventHandler(this.btn_description_Click);
      // 
      // btn_previous
      // 
      this.btn_previous.BackgroundImage = global::ProyectoCATALOGO.Properties.Resources.fondovacio;
      this.btn_previous.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn_previous.FlatAppearance.BorderSize = 0;
      this.btn_previous.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btn_previous.Image = ((System.Drawing.Image)(resources.GetObject("btn_previous.Image")));
      this.btn_previous.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
      this.btn_previous.Location = new System.Drawing.Point(51, 350);
      this.btn_previous.Name = "btn_previous";
      this.btn_previous.Size = new System.Drawing.Size(135, 114);
      this.btn_previous.TabIndex = 2;
      this.btn_previous.UseVisualStyleBackColor = true;
      this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
      // 
      // btn_next
      // 
      this.btn_next.BackgroundImage = global::ProyectoCATALOGO.Properties.Resources.fondovacio;
      this.btn_next.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btn_next.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
      this.btn_next.FlatAppearance.BorderSize = 0;
      this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btn_next.Image = ((System.Drawing.Image)(resources.GetObject("btn_next.Image")));
      this.btn_next.ImageAlign = System.Drawing.ContentAlignment.TopRight;
      this.btn_next.Location = new System.Drawing.Point(575, 350);
      this.btn_next.Name = "btn_next";
      this.btn_next.Size = new System.Drawing.Size(135, 114);
      this.btn_next.TabIndex = 0;
      this.btn_next.UseVisualStyleBackColor = true;
      this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
      // 
      // img_IceCream
      // 
      this.img_IceCream.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.img_IceCream.Image = ((System.Drawing.Image)(resources.GetObject("img_IceCream.Image")));
      this.img_IceCream.Location = new System.Drawing.Point(-3, -2);
      this.img_IceCream.Name = "img_IceCream";
      this.img_IceCream.Size = new System.Drawing.Size(768, 768);
      this.img_IceCream.TabIndex = 1;
      this.img_IceCream.TabStop = false;
      this.img_IceCream.Tag = "chocobomb";
      // 
      // btn_PopupDescription
      // 
      this.btn_PopupDescription.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn_PopupDescription.Location = new System.Drawing.Point(51, 589);
      this.btn_PopupDescription.Name = "btn_PopupDescription";
      this.btn_PopupDescription.Size = new System.Drawing.Size(659, 140);
      this.btn_PopupDescription.TabIndex = 5;
      this.btn_PopupDescription.Text = "button1";
      this.btn_PopupDescription.UseVisualStyleBackColor = true;
      this.btn_PopupDescription.Click += new System.EventHandler(this.btn_PopupDescription_Click);
      // 
      // btn_Database
      // 
      this.btn_Database.BackgroundImage = global::ProyectoCATALOGO.Properties.Resources.fondovacio;
      this.btn_Database.FlatAppearance.BorderSize = 0;
      this.btn_Database.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btn_Database.Image = ((System.Drawing.Image)(resources.GetObject("btn_Database.Image")));
      this.btn_Database.Location = new System.Drawing.Point(575, 181);
      this.btn_Database.Name = "btn_Database";
      this.btn_Database.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.btn_Database.Size = new System.Drawing.Size(77, 104);
      this.btn_Database.TabIndex = 6;
      this.btn_Database.UseVisualStyleBackColor = true;
      // 
      // Catalogo
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(764, 741);
      this.Controls.Add(this.btn_Database);
      this.Controls.Add(this.btn_PopupDescription);
      this.Controls.Add(this.btn_recipe);
      this.Controls.Add(this.btn_description);
      this.Controls.Add(this.btn_previous);
      this.Controls.Add(this.btn_next);
      this.Controls.Add(this.img_IceCream);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.HelpButton = true;
      this.MaximizeBox = false;
      this.Name = "Catalogo";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "proyectoCATALOGO";
      ((System.ComponentModel.ISupportInitialize)(this.img_IceCream)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btn_next;
    private System.Windows.Forms.PictureBox img_IceCream;
    private System.Windows.Forms.Button btn_previous;
    private System.Windows.Forms.Button btn_description;
    private System.Windows.Forms.Button btn_recipe;
    private System.Windows.Forms.Button btn_PopupDescription;
    private System.Windows.Forms.Button btn_Database;
  }
}

