
using System;
using LibMVCS = XTC.FMP.LIB.MVCS;
using XTC.FMP.MOD.ProcessInvoker.LIB.Bridge;
using XTC.FMP.MOD.ProcessInvoker.LIB.MVCS;

namespace XTC.FMP.MOD.ProcessInvoker.LIB.Unity
{
    /// <summary>
    /// 虚拟视图，用于处理消息订阅
    /// </summary>
    public class DummyView :  DummyViewBase
    {
        public DummyView(string _uid) : base(_uid)
        {
        }

        protected override void setup()
        {
            base.setup();
        }
    }
}

