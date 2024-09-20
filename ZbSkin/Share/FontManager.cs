using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace ZbSkin.Share
{
    public class FontManager
    {
        public static readonly string IconFont = @"IconFont";
        private static readonly string IconFontFileName = @"iconfont.ttf";

        private readonly Dictionary<string, FontFamily> _fontFamilyDic;

        /// <summary>
        /// 添加支持的字体
        /// </summary>
        /// <param name="fontName">字体名称</param>
        /// <param name="fontFileName">字体文件名</param>
        /// <remarks>字体文件需要存放在Fonts目录下</remarks>
        public void AddFont(string fontName, string fontFileName)
        {
            if (string.IsNullOrWhiteSpace(fontName) || string.IsNullOrWhiteSpace(fontFileName))
            {
                return;
            }

            if (_fontFamilyDic.ContainsKey(fontName))
            {
                return;
            }

            try
            {
                var appPath = Application.StartupPath;
                var font = new PrivateFontCollection();
                font.AddFontFile($"{appPath}/Fonts/{fontFileName}"); //字体的路径及名字
                _fontFamilyDic.Add(fontName, font.Families[0]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// 为控件设置字体
        /// </summary>
        /// <param name="control">控件对象</param>
        /// <param name="fontName">字体名称</param>
        /// <param name="text">控件文本</param>
        /// <param name="fontSize">字体大小</param>
        /// <remarks>字体需要是内置iconfont字体或者已经添加的字体</remarks>
        public void InitControlFont(Control control, string fontName, string text, int fontSize)
        {
            InitControlFont(control, fontName, fontSize);
            control.Text = text;
        }

        /// <summary>
        /// 为控件设置字体
        /// </summary>
        /// <param name="control">控件对象</param>
        /// <param name="fontName">字体名称</param>
        /// <param name="fontSize">字体大小</param>
        /// <remarks>字体需要是内置iconfont字体或者已经添加的字体</remarks>
        public void InitControlFont(Control control, string fontName, int fontSize)
        {
            var fontFamily = GetFontFamily(fontName);
            if (fontFamily == null)
            {
                return;
            }

            control.Font = new Font(fontFamily, fontSize);
        }

        /// <summary>
        /// 获取字体
        /// </summary>
        /// <param name="fontFileName">字体文件名称</param>
        /// <param name="fontSize">字体大小</param>
        /// <returns>字体对象</returns>
        /// <remarks>字体文件需要存放在Fonts目录下，无需添加到字体字典中</remarks>
        public Font GetFont(string fontFileName, int fontSize)
        {
            if (string.IsNullOrWhiteSpace(fontFileName))
            {
                return null;
            }

            try
            {
                var appPath = Application.StartupPath;
                var font = new PrivateFontCollection();
                font.AddFontFile($"{appPath}/{fontFileName}"); //字体的路径及名字
                return new Font(font.Families[0], fontSize);
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void Init()
        {
            AddFont(IconFont, IconFontFileName);
        }

        private FontFamily GetFontFamily(string fontName)
        {
            if (string.IsNullOrEmpty(fontName))
            {
                return null;
            }

            return _fontFamilyDic.ContainsKey(fontName) ? _fontFamilyDic[fontName] : null;
        }

        #region 单例模式

        private FontManager()
        {
            _fontFamilyDic = new Dictionary<string, FontFamily>();
            Init();
        }

        private static FontManager _instance;
        private static readonly object LockHelper = new object();

        public static FontManager Instance
        {
            get
            {
                if (null != _instance)
                {
                    return _instance;
                }

                lock (LockHelper)
                {
                    _instance = _instance ?? new FontManager();
                }

                return _instance;
            }
        }

        #endregion
    }
}
