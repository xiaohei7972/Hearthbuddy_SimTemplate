using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TSC_086 : SimTemplate //* 剑鱼 Swordfish
//战吼：探底。如果选中的是海盗牌，使这把武器和该海盗获得+2攻击力。
//Battlecry: Dredge.If it's a Pirate, give this weapon and the Pirate +2 Attack.
    {


        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TSC_086);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);

            // 1. 探底选中的牌
            CardDB.Card selectedCard = CardDB.Instance.getCardDataFromID(Hrtprozis.Instance.enchs.LastOrDefault());

            // 2. 判断选中的卡牌是否是海盗（或融合怪）
            if (selectedCard != null && (selectedCard.race == CardDB.Race.PIRATE || selectedCard.race == CardDB.Race.ALL))
            {
                // 3. 如果选中的是海盗牌，为武器和该海盗随从增加 +2 攻击力
                if (target != null)
                {
                    p.ownWeapon.Angr += 2; // 增加己方武器的攻击力
                    target.Angr += 2; // 增加目标随从（海盗）的攻击力
                }
            }
        }
    }
}