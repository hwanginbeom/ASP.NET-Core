using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


// 웹 페이지에 레이블을 떨어뜨려 놓고 해당 레이블에 웹 브라우저가 로드되는 순간의 서버 측 시간을 구해서 출력해보자.

namespace DevStandardControl
{
    public partial class FrmLabel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.lblDateTime.Text = DateTime.Now.ToString();

        }
    }
}