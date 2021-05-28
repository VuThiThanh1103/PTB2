using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PTB2.Controllers
{
    public class PTB2Controller : Controller
    {
        // GET: PTB2
        public ActionResult GPT(String soa, String sob, String soc)
        {
            Double a, b, c, delta;
            String ketqua = " ";
            a = Convert.ToDouble(soa);
            b = Convert.ToDouble(sob);
            c = Convert.ToDouble(soc);
            delta = b * b - 4 * a * c;
            if (a == 0)
            {
                if (b == 0)
                {
                    ketqua = ("Phuong Trinh Vo Nghiem");
                }
                else
                {
                    Double x = -c / b;
                    ketqua = ("Vay nghiem cua phuong trinh la:  " + x);
                }
            }
            else
            {
                if (delta < 0)
                {
                    ketqua = ("Vay phuong trinh vo nghiem");
                }
                else if (delta == 0)
                {
                    Double x11 = -b / 2 * a;
                    ketqua = ("Phuong trinh co nghiem kep:  " + x11);
                }
                else if (delta > 0)
                {
                    Double x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                    Double x2 = (-b - Math.Sqrt(delta)) / 2 * a;
                    ketqua = ("Phuong trinh co hai nghiem phan biet: ");
                    ketqua = ("Nghiem thu nhat: " + x1);
                    ketqua = ("Nghiem thu hai: " + x2);
                }

            }
            ViewBag.abc = ketqua;
            return View();
            }
        }
    }
