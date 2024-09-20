using System;
using System.Drawing;

namespace ZbSkin.Share
{
    public static class CommonPara
    {
        //皮肤颜色值
        public static Color SkinColor = Color.Transparent;

        //APP启动时间
        public static DateTime AppStartTime = DateTime.Now;

        //皮肤图片(便于单独使用控件)
        public static Bitmap ImageNextGen => Properties.Resources.skin01; //次世代
        public static Bitmap ImageFestivalRed => Properties.Resources.skin03; //喜庆红
        public static Bitmap ImageEyeGreen => Properties.Resources.skin06; //护眼绿
        public static Bitmap ImageGrass => Properties.Resources.skin13; //青草地
        public static Bitmap ImageStateGrid => Properties.Resources.skin25; //国网绿
        public static Bitmap ImagePeacockBlue => Properties.Resources.skin19; //孔雀蓝
    }
}
