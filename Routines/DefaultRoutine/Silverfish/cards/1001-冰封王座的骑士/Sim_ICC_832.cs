using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_832: SimTemplate //* 污染者玛法里奥 Malfurion the Pestilent
//[x]<b>Choose One -</b>Summon 2 <b>Poisonous</b>Spiders; or 2 Scarabswith <b>Taunt</b>.
//<b>抉择：</b>召唤两只具有<b>剧毒</b>的蜘蛛；或者召唤两只具有<b>嘲讽</b>的甲虫。 
    {
        

        CardDB.Card kidSpider = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ICC_832t3); 
        CardDB.Card kidScarab = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ICC_832t4); 
        
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.setNewHeroPower(CardDB.cardIDEnum.ICC_832p, ownplay); 
            if (ownplay) p.ownHero.armor += 5;
            else p.enemyHero.armor += 5;

            if (choice == 1 || (p.ownFandralStaghelm > 0 && ownplay))
            {
                int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
                p.callKid(kidSpider, pos, ownplay);
                p.callKid(kidSpider, pos, ownplay);
            }
            if (choice == 2 || (p.ownFandralStaghelm > 0 && ownplay))
            {
                int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
                p.callKid(kidScarab, pos, ownplay);
                p.callKid(kidScarab, pos, ownplay);
            }
        }
    }
}