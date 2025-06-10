using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_252 : SimTemplate //* 高阶祭司耶克里克 High Priestess Jeklik
//[x]<b>Taunt</b>, <b>Lifesteal</b>When you discard this,add 2 copies of it toyour hand.
//<b>嘲讽，吸血</b>当你弃掉这张牌时，将这张牌的两张复制置入你的手牌。 
	{
		


        public override bool onCardDicscard(Playfield p, Handmanager.Handcard hc, Minion own, int num, bool checkBonus)
        {
            if (checkBonus) return true;
			if (own != null) return false;

            p.drawACard(CardDB.cardNameEN.highpriestessjeklik, true, true);
			p.drawACard(CardDB.cardNameEN.highpriestessjeklik, true, true);
            int i = p.owncards.Count - 2;
            return true;
        }
    }
}