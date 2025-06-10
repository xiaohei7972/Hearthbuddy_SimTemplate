using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_SW_048 : SimTemplate //* 棱彩珠宝工具 Prismatic Jewel Kit
	{
        //[x]After a friendly minion loses<b>Divine Shield</b>, give minionsin your hand  +1/+1.Lose 1 Durability.
        //在一个友方随从失去<b>圣盾</b>后，使你手牌中的随从牌获得+1/+1。失去1点耐久度。
        CardDB.Card weapon = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SW_048);
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(weapon, ownplay);
        }
        public override void onMinionLosesDivineShield(Playfield p, Minion m, int num)
        {
            p.ownWeapon.Durability -= num;
            if (p.ownWeapon.Durability < 0) num += p.ownWeapon.Durability;
            foreach (Handmanager.Handcard hc in p.owncards)
            {
                if (hc.card.type == CardDB.cardtype.MOB)
                {
                    hc.addattack += num;
                    hc.addHp += num;
                    p.anzOwnExtraAngrHp += 2 * num;
                    p.evaluatePenality -= p.mana;
                }
            }
        }
    }
}
