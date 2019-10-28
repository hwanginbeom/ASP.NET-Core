using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/*

6.1 | HTML 대체 컨트롤이란?
 

ASP.NET에서 제공하는 표준 컨트롤 중에는 하이퍼링크, 이미지, 이미지맵, 테이블 등 기존에 HTML 태그로 정적으로 표현하던 
내용을 서버 컨트롤을 사용해 선언적 및 동적으로 HTML 태그를 만들어 내는 컨트롤 등을 제공한다.


속성

NavigateUrl - 링크를 클릭했을 때 이동할 경로

ImageUrl - 일반 텍스트 대신 이미지를 링크로 만들고자 할 때 사용


 */


namespace DevStandardControl
{
    public partial class FrmHyperLink : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.lnkDotNetKorea.AccessKey = "D";

        }
    }
}