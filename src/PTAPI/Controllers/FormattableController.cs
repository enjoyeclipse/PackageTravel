using System;
using System.Web.Mvc;
using PTCore;

namespace PTAPI.Controllers
{
    [ValidateInput(false)]
    public class FormattableController : Controller
    {
        private readonly string[] _validateFormats = new[] { "json", "xml" };
        public string Format { get; set; }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);

  
            var formateKey = filterContext.HttpContext.Request.Params["format"];
            if (!string.IsNullOrEmpty(formateKey))
            {
                if (Array.Exists(_validateFormats, x => x == formateKey))
                {
                    Format = formateKey;
                    return;
                }
            }
            Format = "xml";
        }

        public ActionResult XmlResult(object viewModel)
        {
            return new XmlResult(viewModel, viewModel.GetType());
        }

        [ValidateInput(false)]
        public ActionResult FormatResult(object viewModel)
        {
            if (viewModel == null)
            {
                throw new NullReferenceException("The object viewModel is null");
            }

            if (Format == null)
            {
                Format = "xml";
            }

            switch (Format)
            {
                case "xml":
                    return XmlResult(viewModel);

                case "json":
                    return Json(viewModel);

                default:
                    throw new Exception("The format is not supported");
            }
        }

    }
}