using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/*
6.5 | 실습_ Image 컨트롤을 사용해 이미지 표시하기
6.5.1 소개

이미지 컨트롤을 사용해 HTML의 img 태그를 만들고, 추가 기능을 적용해보자.


속성

AlternateText - 이미지가 표시되지 않을 때 나타나는 대체 텍스트

ImageUrl - 이미지 컨트롤에 보여질 이미지 경로


 */


namespace DevStandardControl
{
    public partial class _6__5_FrmImage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnChange_Click(object sender, EventArgs e)
        {
            if (DateTime.Now.Second % 2 == 0)
            {
                imgChange.ImageUrl = "~/images/ASP-NET-Banners-01.png";
            }
            else
            {
                imgChange.ImageUrl = "~/images/ASP-NET-Banners-02.png";
            }

        }
    }
}