using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_750 : SimTemplate //* 唤魔者克鲁尔 Krul the Unshackled
//[x]<b>Battlecry:</b> If your deck hasno duplicates, summon all_Demons from your hand._
//<b>战吼：</b>如果你的牌库里没有相同的牌，则召唤你手牌中的所有恶魔。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            if (m.own)
            {
                if (p.prozis.noDuplicates)
                {
				    if (p.ownMinions.Count < 7)
				    {
					    bool needTrigger = false;
					    foreach (Handmanager.Handcard hc in p.owncards.ToArray())
					    {
                            if ((TAG_RACE)hc.card.race == TAG_RACE.DEMON)
						    {
							    p.callKid(hc.card, p.ownMinions.Count, true);
							    p.removeCard(hc);
							    needTrigger = true;
							    if (p.ownMinions.Count > 6) break;
						    }
					    }
					    if (needTrigger) p.triggerCardsChanged(true);
				    }
                }
            }
            else
            {
                if (p.enemyAnzCards > 1)
                {
                    int pos = p.enemyMinions.Count;
                    p.callKid(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_306), pos, false); 
                    p.enemyAnzCards--;
                    p.triggerCardsChanged(false);
                    if (p.ownHeroHasDirectLethal())
                    {
                        p.enemyMinions[pos].Angr = 2;
                        if (p.ownHeroHasDirectLethal())
                        {
                            p.enemyMinions[pos].Angr = 0;
                        }
                    }
                }
            }
        }
    }
}