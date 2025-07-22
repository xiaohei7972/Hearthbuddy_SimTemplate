using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ULD_726 : SimTemplate //* 远古谜团 Ancient Mysteries
	{
		//Draw a <b>Secret</b> from your deck. It costs (0).
		//从你的牌库中抽一张<b>奥秘</b>牌。其法力值消耗为（0）点。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardNameEN.splittingimage,ownplay,true); //裂魂残像没有太多副作用影响判断
            if(p.owncards.Count > 0){
                Handmanager.Handcard newHc = p.owncards[p.owncards.Count - 1];
                newHc.manacost = 0;
            }
			
        }
		
	}
}
