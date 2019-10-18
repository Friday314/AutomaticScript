using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AutomaticScript
{
    /// <summary>
    /// 百度文字识别API接口
    /// </summary>
    class BaiDuAPI
    {
        // 设置APPID/AK/SK
        static string APP_ID = "17555400";
        static string API_KEY = "riHcQfvEkl6apptzEIBBOW0w";
        static string SECRET_KEY = "WqQykyN3Ndp1gMWlRaH4LkTLSUzRo8wm";

        /// <summary>
        /// 通用文字识别
        /// </summary>
        /// <param name="imgPath">图片地址</param>
        /// <returns></returns>
        public string Ocr_Baidu(string imgPath)
        {
            var client = new Baidu.Aip.Ocr.Ocr(API_KEY, SECRET_KEY);
            client.Timeout = 60000;  // 修改超时时间

            var image = File.ReadAllBytes(imgPath);

            // 调用通用文字识别, 图片参数为本地图片，可能会抛出网络等异常，请使用try/catch捕获
            var result = client.GeneralBasic(image);

            //Console.WriteLine(result);
            // 如果有可选参数
            var options = new Dictionary<string, object>{
                                        //CHN_ENG：中英文混合；
                                        {"language_type", "CHN_ENG"},
                                        //是否检测图像朝向，默认不检测，- true：检测朝向；
                                        {"detect_direction", "true"},
                                        //是否检测语言，默认不检测。- true：检测语言；
                                        {"detect_language", "true"},
                                        //是否返回识别结果中每一行的置信度
                                        {"probability", "true"}
                                        };
            // 带参数调用通用文字识别, 图片参数为本地图片
            result = client.GeneralBasic(image, options);

            //Console.WriteLine(result);

            string str = result.ToString();
            var StrJOb = JObject.Parse(str);
            var text = from obj in (JArray)StrJOb["words_result"] select (string)obj["words"];
            string coordinate = "";
            foreach (var r in text)
                coordinate = r;

            return coordinate;
        }

        /// <summary>
        /// 高精度文字识别
        /// </summary>
        /// <param name="imgPath"></param>
        /// <returns></returns>
        public string Ocr_Acc_BaiDu(string imgPath)
        {
            var client = new Baidu.Aip.Ocr.Ocr(API_KEY, SECRET_KEY);
            client.Timeout = 60000;  // 修改超时时间

            var image = File.ReadAllBytes(imgPath);

            // 调用通用文字识别（高精度版），可能会抛出网络等异常，请使用try/catch捕获
            var result = client.AccurateBasic(image);

            //Console.WriteLine(result);
            // 如果有可选参数
            var options = new Dictionary<string, object>{
                                        //是否检测图像朝向，默认不检测，- true：检测朝向；
                                        {"detect_direction", "true"},
                                        //是否返回识别结果中每一行的置信度
                                        {"probability", "true"}
                                        };
            // 带参数调用通用文字识别（高精度版）
            result = client.AccurateBasic(image, options);
            //Console.WriteLine(result);

            string str = result.ToString();
            var StrJOb = JObject.Parse(str);
            var text = from obj in (JArray)StrJOb["words_result"] select (string)obj["words"];
            string coordinate = "";
            foreach (var r in text)
                coordinate = r;

            return coordinate;
        }
    }
}
