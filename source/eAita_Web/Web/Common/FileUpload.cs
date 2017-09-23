using Business.Business;
using Business.CommonBusiness;
using Model.eAita;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using Web.Custom;
using Web.FwCore;

namespace Web.Common
{

    public class FileUpload
    {
        Entities context = new Entities();
     
        /// <summary>
        /// LƯU FILE UPLOAD NHÂN SỰ
        /// </summary>
        /// <param name="files"></param>
        /// <param name="ItemID"></param>
        /// <param name="Path"></param>
        /// <param name="UserID"></param>
        /// <param name="TypeItem"></param>
        /// <param name="TypeFile"></param>
        /// <returns></returns>
        public bool SaveFiles(IEnumerable<HttpPostedFileBase> files, int ItemID, string Path, long UserID, int LoaiTaiLieu, int TypeFile, string fileExtensions, long MaxSize, string[] filename)
        {
            UserInfoBO UserInfo = (UserInfoBO)SessionManager.GetUserInfo();
            int count = 0;
            var extend = fileExtensions.ToListStringLower(',');
            if (files != null && files.Count() > 0)
            {
                foreach (var file in files)
                {
                    if (file != null && file.ContentLength > 0)
                    {
                        if (string.IsNullOrEmpty(filename[count]))
                        {
                            filename[count] = file.FileName;
                        }
                        FileInfo info = new FileInfo(file.FileName);
                        //Load lan luot định dạng file cho phép
                        bool IsMaxSize = false;
                        if (MaxSize == 0)
                        {
                            IsMaxSize = true;
                        }
                        else if (file.ContentLength < MaxSize)
                        {
                            IsMaxSize = true;
                        }
                        else
                        {
                            IsMaxSize = false;
                        }
                        if (IsMaxSize)
                        {
                            if (!string.IsNullOrEmpty(info.Extension) && extend.Contains(info.Extension.ToLower()) && !string.IsNullOrEmpty(Path))
                            {
                             
                                //string folder = Path;
                                //bool folderExists = Directory.Exists(System.Web.HttpContext.Current.Server.MapPath(folder));
                                //if (!folderExists)
                                //{
                                //    Directory.CreateDirectory(System.Web.HttpContext.Current.Server.MapPath(folder));
                                //}
                                //var fileName = System.IO.Path.GetFileName(file.FileName);
                                //string fileExtension = System.IO.Path.GetExtension(file.FileName);
                                //string guid = Guid.NewGuid().ToString().Replace("-", "").ToUpper();
                                //string name = guid + fileExtension;
                                //var path = System.IO.Path.Combine(System.Web.HttpContext.Current.Server.MapPath(folder), name);
                                //file.SaveAs(path);
                                //fileUpload.TENTAILIEU = filename[count].Trim() == "" ? fileName : filename[count].Trim();
                                //fileUpload.DUONGDAN_FILE = path;
                                //fileUpload.LOAI_TAILIEU = LoaiTaiLieu;
                                //fileUpload.FILESIE = file.ContentLength;
                                //fileUpload.ITEM_ID = ItemID;
                                //fileUpload.NGAYTAO = DateTime.Now;
                                //fileUpload.TYPE_FILE = TypeFile;
                                //fileUpload.USER_ID = UserID;
                                //fileUpload.SOLUONG_DOWNLOAD = 0;
                                //fileUpload.DINHDANG_FILE = fileExtension;
                                //fileUpload.DUONGDAN_FILE = path;
                                //HscbFilesBusiness.Save(fileUpload);
                            }
                        }
                    }
                    count++;
                }
                return true;
            }
            return false;
        }
    }
}