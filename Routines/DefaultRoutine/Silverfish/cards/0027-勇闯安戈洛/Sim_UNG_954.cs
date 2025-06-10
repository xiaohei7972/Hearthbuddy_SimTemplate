using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_UNG_954 : SimTemplate //* 最后的水晶龙 The Last Kaleidosaur
//<b>Quest:</b> Cast 6 spellson your minions.<b>Reward:</b> Galvadon.
//<b>任务：</b>对你的随从施放6个法术。<b>奖励：</b>嘉沃顿。 
	{
		

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (p.playactions.Count < 2) p.evaluatePenality -= 30;
        }
    }
}