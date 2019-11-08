using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


/*
 
7.19 | 실습_ Substitution 컨트롤을 사용해 매번 최신 정보로 출력하기
7.19.1 소개

Substitution 컨트롤은 캐싱(Caching ) 기능에 영향을 받지 않고자 할 때 사용한다. 캐싱이란 웹 페이지를 매번 실행하는 대신 서버의 
메모리에 지정된 시간 동안 내용을 담아 놓고 메모리에 담긴 내용을 출력하는 기능이다.
     
     */
namespace DevStandardControl
{
    public partial class _7__19_FrmSubstitution : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 캐싱되어 출력
            lblCachedLabel.Text = DateTime.Now.ToLongTimeString();
        }

        // Substitution 컨트롤에 현재 시간 출력
        public static string GetCurrentTime(HttpContext context)
        {
            return DateTime.Now.ToLongTimeString();
        }
    }
}