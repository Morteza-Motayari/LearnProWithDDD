using LearnProWithDDD.Domain.Exceptions.CourseManagementExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnProWithDDD.Domain.ValueObjects
{
    public record VidoUrl
    {
        public string Value { get; set; }
        public VidoUrl(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new VideoUrlNullOrEmptyException();
            }
            if (value.Length > 100)
            {
                throw new InvalidVideoUrlLengthException();
            }
            if (!value.EndsWith(".mp4"))
            {
                throw new InvalidVideoExtensionException();
            }
            Value = value;
        }
        public static implicit operator string(VidoUrl vidourl)=> vidourl.Value;
        public static implicit operator VidoUrl(string vidourl)=> new(vidourl);
    }
}
