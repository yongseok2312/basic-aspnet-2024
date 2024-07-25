using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Data;
using MyPortfolio.Helper;
using MyPortfolio.Models;
using System.Diagnostics;
using System.Security.Cryptography; // 암호화

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        /*public HomeController(ILogger<HomeController> logger, AppDbContext conetext)
        {
            _logger = logger;
            _context = conetext;    // DB를 연결해서 사용하겟다.
        }*/

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet] // Default로 생략가능
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            // userEmail, password md5로 암호화
            // DB에 있는 값 비교
            var hash = MD5.Create();
            user.Password = Common.GetMd5Hash(hash,user.Password); // 로그인 창에 입력한 암호를 암호화

            var result = _context.User.FirstOrDefault(u => u.UserEmail == user.UserEmail && u.Password == user.Password);
            if(result  == null)
            {
                return View(user);
            }
            else
            {
                // 로그인 세션 처리
                HttpContext.Session.SetInt32("USER_LOGIN_KEY", result.Id);
                HttpContext.Session.SetString("USER_NAME", result.UserName);
                HttpContext.Session.SetString("USER_EMAIL", result.UserEmail);

                return RedirectToAction("Index", "Home");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // 회원로그인으로 새로 추가
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("USER_LOGIN_KEY");
            HttpContext.Session.Remove("USER_NAME");
            HttpContext.Session.Remove("USER_EMAIL");

            return RedirectToAction("Index", "Home");
        }


        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        // 회원 등록 페이지 내용을 DB에 저장
        [HttpPost]
        public async Task<IActionResult> Register(User user)
        {
            if(user.Password != user.PasswordCheck)
            {
                ModelState.AddModelError("PasswordCheck", "패스워드가 일치하지 않습니다");
            }

            if (ModelState.IsValid)
            {
                // 모든 값이 정확히 들어왔음
                user.RegDate = DateTime.Now; // 회원 등록 날짜 오늘로 지정
                var mdHash = MD5.Create();

                user.Password = Common.GetMd5Hash(mdHash,user.Password);
                user.PasswordCheck = null;
                _context.Add(user); // insert
                await _context.SaveChangesAsync(); // Commit
                return RedirectToAction("Login");
            }
            return View(user);
        }
    }
}
