using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_609 : SimTemplate //* 卡雷苟斯 Kalecgos
//Your first spell eachturn costs (0).<b>Battlecry:</b> <b>Discover</b>a spell.
//你每个回合使用的第一张法术牌的法力值消耗为（0）点。<b>战吼：</b><b>发现</b>一张法术牌。 
	{
		
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardNameEN.thecoin, own.own, true);
		}
	}
}