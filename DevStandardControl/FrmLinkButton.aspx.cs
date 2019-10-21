using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/*
5.10 | 실습_ LinkButton 컨트롤을 사용해 링크 모양의 버튼 만들기
5.10.1 소개

링크버튼 컨트롤은 하이퍼링크와 같은 모양이지만, 버튼 컨트롤과 마찬가지로 Click 이벤트를 사용해 코드 숨김 파일에서 특정 기능을 구현할 수 있다.
 */

namespace DevStandardControl
{
    public partial class FrmLinkButton : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void lnkDotNetKorea_Click(object sender, EventArgs e)
        {
            // 닷넷코리아 이동
            Response.Redirect("http://www.dotnetkorea.com/");
        }
    }
}
