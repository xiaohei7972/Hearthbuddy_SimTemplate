using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_145 : SimTemplate //* 加尔范上尉 captaingalvangar
	{
		//<b>战吼：</b>在本局对战中，如果你获得的护甲值大于或等于15点，便获得+3/+3和<b>冲锋</b>。@<i>（还剩{0}点！）</i>@<i>（已经就绪！）</i>
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            //if (!m.silenced)
            //{
            //    m.cantAttack = (p.ownHero.armor > 15) ? true : false;
            //    m.updateReadyness();
            //}
        }
		
	}
}
