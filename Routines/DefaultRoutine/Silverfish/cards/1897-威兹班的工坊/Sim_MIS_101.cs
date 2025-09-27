using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //武器 巫妖王 费用：5 攻击力：5 耐久度：1
    //Foamrender
    //海绵斧
    //Whenever your hero attacks, spend 3 <b>Corpses</b> to gain +1 Durability.
    //每当你的英雄攻击时，消耗3具<b>尸体</b>以获得+1耐久度。
    class Sim_MIS_101 : SimTemplate
    {
        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOOT_222);
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);

        }
        public override void onHeroattack(Playfield p, Minion ownHero, Minion target)
        {

            // 检查是否有足够的尸体来消耗
            if (p.getCorpseCount() >= 3)
            {
                // 消耗3具尸体
                p.corpseConsumption(3);

                // 增加武器的耐久度
                p.lowerWeaponDurability(-1, ownHero.own);
            }

        }
    }
}
