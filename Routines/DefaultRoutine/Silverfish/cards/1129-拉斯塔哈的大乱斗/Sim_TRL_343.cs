using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TRL_343 : SimTemplate //* 战争德鲁伊罗缇 Wardruid Loti
//<b>Choose One - </b>Transform into one of Loti's four dinosaur forms.
//<b>抉择：</b>将该随从变形成为罗缇的四种恐龙形态之一。  
    {
        

        CardDB.Card Ankylodon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TRL_343at1);
        CardDB.Card Sabertusk = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TRL_343bt1);
        CardDB.Card Pterrordax = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TRL_343ct1);
        CardDB.Card Ravasaur = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TRL_343dt1);

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (p.ownFandralStaghelm > 0)
            {
                
            }
            else
            {
                if (choice == 1)
                {
                    p.minionTransform(own, Ankylodon);
                }
                if (choice == 2)
                {
                    p.minionTransform(own, Sabertusk);
                }
				if (choice == 3)
                {
                    p.minionTransform(own, Pterrordax);
                }
				if (choice == 4)
                {
                    p.minionTransform(own, Ravasaur);
                }
            }
		}
	}
}