using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_ICC_834: SimTemplate //* 天灾领主加尔鲁什 Scourgelord Garrosh
//<b>Battlecry</b>: Equip a 4/3_Shadowmourne that also damages adjacent minions.
//<b>战吼：</b>装备一把4/3的影之哀伤，影之哀伤同时对其攻击目标相邻的随从造成伤害。 
    {
        

        CardDB.Card w = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ICC_834w); 

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.setNewHeroPower(CardDB.cardIDEnum.ICC_834h, ownplay); 
            if (ownplay) p.ownHero.armor += 5;
            else p.enemyHero.armor += 5;

            p.equipWeapon(w, ownplay);
        }
    }
}