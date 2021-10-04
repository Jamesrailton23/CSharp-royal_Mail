using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace royalMail
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void performChanged()
        {
            int volume;
            double postagemulti;
            double cost;
            bool formok;

            formok = CheckforIsOk();
            if (formok)
            {
                postagemulti = getPostage();
                volume = getVolume();
                cost = volume * postagemulti;
                Label1.Text = String.Format("{0:C}", cost);
            }
            

        }
        private bool CheckforIsOk()
        {
            if (tb_height.Text.Trim().Length == 0) return false;
            else if (tb_width.Text.Trim().Length == 0) return false;
            else return true;
        }
        private int getVolume()
        {
            int lenght = 1;
            int width = 0;
            int height = 0;
            int volume;
            if (tb_lenght.Text.Trim().Length == 0) lenght = 1;
            else lenght = int.Parse(tb_lenght.Text);
            width = int.Parse(tb_width.Text);
            height = int.Parse(tb_height.Text);
            volume = lenght * width * height;
            return volume;
        }
        private double getPostage()
        {

            if (rb_next_day.Checked) return 0.45;
            else if (rb_first.Checked) return 0.30;
            else if (rb_seccond.Checked) return 0.25;
            else return 0;
        }
    }
}