using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_025 : SimTemplate //* 太阳之井新兵 Sunwell Initiate
	{
		//<b>Frenzy:</b> Gain <b>Divine Shield</b>.
		//<b>暴怒：</b>获得<b>圣盾</b>。
		
		public override void onEnrageStart(Playfield p, Minion m)
        {
            m.divineshild = true;
        }		
		
	}
}
