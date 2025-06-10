using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_165 : SimTemplate //* 利爪德鲁伊 Druid of the Claw
	{
		//[x]<b>Choose One -</b> Transforminto a 5/4 with <b>Rush</b>;or a 5/6 with <b>Taunt</b>.
		//<b>抉择：</b>将该随从变形成为5/4并具有<b>突袭</b>；或者将该随从变形成为5/6并具有<b>嘲讽</b>。
		

        CardDB.Card cat = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_165t1);
        CardDB.Card bear = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_165t2);
        CardDB.Card bearcat = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.OG_044a);

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (p.ownFandralStaghelm > 0)
            {
                p.minionTransform(own, bearcat);
            }
            else
            {
                if (choice == 1)
                {
                    p.minionTransform(own, cat);
                }
                if (choice == 2)
                {
                    p.minionTransform(own, bear);
                }
            }
		}
	}
}
