using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_165 : SimTemplate //* 利爪德鲁伊 Druid of the Claw
	{
		//[x]<b>Choose One -</b> Transforminto a 4/4 with <b>Charge</b>;or a 4/6 with <b>Taunt</b>.
		//<b>抉择：</b>将该随从变形成为4/4并具有<b>冲锋</b>；或者将该随从变形成为4/6并具有<b>嘲讽</b>。
		

        CardDB.Card cat = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAN_EX1_165t1);
        CardDB.Card bear = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAN_EX1_165t2);
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