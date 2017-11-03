using System;

namespace Univalle.Fie.Sistemas.Unibook.Mvc.WebPeople.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}