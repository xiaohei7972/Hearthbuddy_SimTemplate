using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_126 : SimTemplate //* 钩牙船长 Captain Hooktusk
//<b>Battlecry:</b> Summon 3 Pirates from your deck. Give them <b>Rush</b>.
//<b>战吼：</b>从你的牌库中召唤三个海盗，并使其获得<b>突袭</b>。 
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.GIL_557); //突袭海盗:被诅咒的海盗
		public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
		{
			int pos = (m.own) ? p.ownMinions.Count : p.enemyMinions.Count;
            p.callKid(kid, pos, m.own, false);
			if (m.own)p.ownDeckSize--;
            else p.enemyDeckSize--;
			p.callKid(kid, pos, m.own, false);
			if (m.own)p.ownDeckSize--;
            else p.enemyDeckSize--;
			p.callKid(kid, pos, m.own, false);
			if (m.own)p.ownDeckSize--;
            else p.enemyDeckSize--;
		}
	}
}