using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_281 : SimTemplate //* 邪火爆弹 felfireinthehole
	{
		//抽一张法术牌，对所有敌人造成$2点伤害。如果抽到的是邪能法术牌，则造成的伤害增加$1点。
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            bool foundFEL = false;
            bool foundSpell = false;
            //CardDB.cardIDEnum deckMinion = CardDB.cardIDEnum.None;
            // 遍历卡组
            foreach (KeyValuePair<CardDB.cardIDEnum, int> kvp in p.prozis.turnDeck)
            {
                // ID 转卡
                CardDB.cardIDEnum deckCard = kvp.Key;
                CardDB.Card deckSpell = CardDB.Instance.getCardDataFromID(deckCard);
                if (!foundSpell && deckSpell.type == CardDB.cardtype.SPELL)
                {
                    p.drawACard(deckCard, true);
                    foundSpell = true;
                    if (deckSpell.SpellSchool == CardDB.SpellSchool.FEL)
                    {
                        foundFEL = true;
                        break;
                    }
                }
            }
            int dmg = p.getEnemySpellDamageDamage(2);
            p.allMinionsGetDamage(dmg);
            if (foundFEL)
            {
                dmg = p.getEnemySpellDamageDamage(2);
                p.allMinionsGetDamage(dmg);
            }
            
        }
		
	}
}
