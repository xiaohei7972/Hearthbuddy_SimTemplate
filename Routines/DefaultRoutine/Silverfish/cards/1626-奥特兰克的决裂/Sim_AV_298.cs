using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_298 : SimTemplate //* 蛮爪豺狼人 wildpawgnoll
	{
		//<b>突袭</b>。你每将一张另一职业的牌置入你的手牌，法力值消耗便减少（1）点。
        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool ownplay, Handmanager.Handcard triggerhc)
        {
            //if (ownplay)
            //{
            //    int heroClass = (int)p.ownHeroStartClass;
            //    foreach (Handmanager.Handcard hc_ in p.owncards)
            //    {
            //        if (hc_.card.Class != heroClass && hc_.card.Class != 0)
            //        {
            //            triggerhc.manacost -= 1;
            //        }
            //    }
            //}
        }
		
	}
}
