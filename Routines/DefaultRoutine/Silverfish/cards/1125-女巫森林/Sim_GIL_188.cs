using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_188 : SimTemplate //* 镰刀德鲁伊 Druid of the Scythe
//[x]<b>Choose One -</b> Transforminto a 4/2 with <b>Rush</b>;or a 2/4 with <b>Taunt</b>.
//<b>抉择：</b>将该随从变形成为4/2并具有<b>突袭</b>；或者将该随从变形成为2/4并具有<b>嘲讽</b>。 
	{
		
        
        CardDB.Card cRush = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.GIL_188t);
        CardDB.Card cStealth = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.GIL_188t2);
        CardDB.Card cTiger = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.OG_044c);
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (p.ownFandralStaghelm > 0)
            {
                p.minionTransform(own, cTiger);
            }
            else
            {
                if (choice == 1)
                {
                    p.minionTransform(own, cRush);
                }
                if (choice == 2)
                {
                    p.minionTransform(own, cStealth);
                }
            }
		}
	}
}