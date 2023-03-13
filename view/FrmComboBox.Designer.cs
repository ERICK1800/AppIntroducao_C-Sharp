
namespace AppIntroducao.view
{
    partial class FrmComboBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPalavra = new System.Windows.Forms.TextBox();
            this.lblTextoSel = new System.Windows.Forms.TextBox();
            this.lblPosItem = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimparComboBox = new System.Windows.Forms.Button();
            this.btnLimparPalavra = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.cboDropDownList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(73, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite uma palavra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(59, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estilo DropDownList:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(96, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Posição na lista:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(77, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Texto selecionado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(438, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total de itens:";
            // 
            // txtPalavra
            // 
            this.txtPalavra.Location = new System.Drawing.Point(256, 66);
            this.txtPalavra.Name = "txtPalavra";
            this.txtPalavra.Size = new System.Drawing.Size(357, 20);
            this.txtPalavra.TabIndex = 5;
            this.txtPalavra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPalavra_KeyPress);
            // 
            // lblTextoSel
            // 
            this.lblTextoSel.Location = new System.Drawing.Point(256, 242);
            this.lblTextoSel.Name = "lblTextoSel";
            this.lblTextoSel.Size = new System.Drawing.Size(357, 20);
            this.lblTextoSel.TabIndex = 7;
            // 
            // lblPosItem
            // 
            this.lblPosItem.Location = new System.Drawing.Point(256, 181);
            this.lblPosItem.Name = "lblPosItem";
            this.lblPosItem.Size = new System.Drawing.Size(176, 20);
            this.lblPosItem.TabIndex = 8;
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(567, 183);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(46, 20);
            this.lblTotal.TabIndex = 9;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAdicionar.Location = new System.Drawing.Point(619, 66);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(309, 35);
            this.btnAdicionar.TabIndex = 10;
            this.btnAdicionar.Text = "Adicionar no ComboBox";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEliminar.Location = new System.Drawing.Point(619, 107);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(309, 35);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar Item Selecionado";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimparComboBox
            // 
            this.btnLimparComboBox.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLimparComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparComboBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLimparComboBox.Location = new System.Drawing.Point(619, 148);
            this.btnLimparComboBox.Name = "btnLimparComboBox";
            this.btnLimparComboBox.Size = new System.Drawing.Size(309, 35);
            this.btnLimparComboBox.TabIndex = 12;
            this.btnLimparComboBox.Text = "Limpar ComboBox";
            this.btnLimparComboBox.UseVisualStyleBackColor = false;
            this.btnLimparComboBox.Click += new System.EventHandler(this.btnLimparComboBox_Click);
            // 
            // btnLimparPalavra
            // 
            this.btnLimparPalavra.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLimparPalavra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparPalavra.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLimparPalavra.Location = new System.Drawing.Point(619, 189);
            this.btnLimparPalavra.Name = "btnLimparPalavra";
            this.btnLimparPalavra.Size = new System.Drawing.Size(309, 35);
            this.btnLimparPalavra.TabIndex = 13;
            this.btnLimparPalavra.Text = "Limpar Campo Palavra";
            this.btnLimparPalavra.UseVisualStyleBackColor = false;
            this.btnLimparPalavra.Click += new System.EventHandler(this.btnLimparPalavra_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSair.Location = new System.Drawing.Point(619, 230);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(309, 35);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // cboDropDownList
            // 
            this.cboDropDownList.FormattingEnabled = true;
            this.cboDropDownList.Location = new System.Drawing.Point(256, 120);
            this.cboDropDownList.Name = "cboDropDownList";
            this.cboDropDownList.Size = new System.Drawing.Size(357, 21);
            this.cboDropDownList.TabIndex = 15;
            this.cboDropDownList.SelectedIndexChanged += new System.EventHandler(this.cboDropDownList_SelectedIndexChanged);
            // 
            // FrmComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(940, 344);
            this.Controls.Add(this.cboDropDownList);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimparPalavra);
            this.Controls.Add(this.btnLimparComboBox);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPosItem);
            this.Controls.Add(this.lblTextoSel);
            this.Controls.Add(this.txtPalavra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmComboBox";
            this.Text = "Combo Box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPalavra;
        private System.Windows.Forms.TextBox lblTextoSel;
        private System.Windows.Forms.TextBox lblPosItem;
        private System.Windows.Forms.TextBox lblTotal;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimparComboBox;
        private System.Windows.Forms.Button btnLimparPalavra;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ComboBox cboDropDownList;
    }
}