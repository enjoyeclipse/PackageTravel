﻿using System;
using System.IO;
using System.Web;
using System.Web.Mvc;
using System.Xml.Serialization;

namespace PTCore
{
    public class XmlResult : ActionResult
    {
        // 可被序列化的内容 
        public object Data { get; set; }

        // Data的类型 
        public Type DataType { get; set; }

        // 构造器
        public XmlResult(object data, Type type)
        {
            Data = data;
            DataType = type;
        }

        // 主要是重写这个方法
        public override void ExecuteResult(ControllerContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }

            HttpResponseBase response = context.HttpContext.Response;

            // 设置 HTTP Header 的 ContentType
            response.ContentType = "text/xml";

            if (Data != null)
            {
                // 序列化 Data 并写入 Response
                var serializer = new XmlSerializer(DataType);
                var ms = new MemoryStream();
                serializer.Serialize(ms, Data);
                response.Write(System.Text.Encoding.UTF8.GetString(ms.ToArray()));
            }
        }
    }
}
