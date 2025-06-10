using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_070 : SimTemplate //* 砰砰机甲 The Boom Reaver
//<b>Battlecry:</b> Summon a copy of a minion in your deck. Give it <b>Rush</b>.
//<b>战吼：</b>召唤一个你牌库中的随从的复制，并使其获得<b>突袭</b>。 
	{
        

		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.GVG_058);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int pos =(ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;

            p.callKid(kid, pos, ownplay, false);
			if (ownplay) p.evaluatePenality -= 10;
		}

	}
}