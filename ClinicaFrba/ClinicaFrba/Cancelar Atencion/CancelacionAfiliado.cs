﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaFrba.Cancelar_Atencion
{
    public partial class CancelacionAfiliado : Form
    {
        public string idAfiliado;
        public CancelacionAfiliado(string strAfiliado)
        {
            InitializeComponent();
            idAfiliado = strAfiliado;
        }
        
        private void CancelacionAfiliado_Load(object sender, EventArgs e)
        {
            
        }
    }
}
