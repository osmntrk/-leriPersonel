using İleriPersonel.Context;
using İleriPersonel.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İleriPersonel
{
    public partial class FrmCalısan : FrmTemel
    {
        public FrmCalısan()
        {
            InitializeComponent();
        }
        PersonelContext db = new PersonelContext();
        private void FrmCalısan_Load(object sender, EventArgs e)
        {
            Doldur();
            DoldurCombobox();
            DoldurComboboxIlce(1);
        }

        private void Doldur()
        {
            dataGridView1.DataSource = db.Set<Calısan>().Select(x => new InsanDTO
            {
                Id = x.Id,
                Ad=x.Ad,
                Soyad=x.Soyad,
                IlceAd=x.Ilce.Ad,
                Sehir=x.Ilce.sehir.Ad
            }).ToList();
            ToString();


        }

        private void DoldurComboboxIlce(int v)
        {
            cmbIlce.DataSource = db.Set<Ilce>().Select(x => new
            {
                ad = x.Ad,
                ıd = x.Id,
                sehirId=x.SehirId



            }).Where(x=>x.sehirId==v).ToList();
            cmbIlce.DisplayMember = "Ad";
            cmbIlce.ValueMember = "Id";

        }

        private void DoldurCombobox()
        {
            cmbEgitim.DataSource = db.Set<Egitim>().Select(x => new
            {
                ad=x.Ad,
                ıd=x.Id,
                
            }).ToList();
            cmbEgitim.DisplayMember = "Ad";
            cmbEgitim.ValueMember = "Id";

            cmbSehir.DataSource = db.Set<Sehir>().Select(x => new
            {
                ad = x.Ad,
                ıd = x.Id

            }).ToList();
            cmbSehir.DisplayMember = "Ad";
            cmbSehir.ValueMember = "Id";
        }

        private void cmbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secilenSehirId = 0;
            try
            {
                secilenSehirId = (int)cmbSehir.SelectedValue;
                DoldurComboboxIlce(secilenSehirId);

            }
            catch (Exception)
            {

            }
            
        }
        class object
        {

        }
    }


    
    }

