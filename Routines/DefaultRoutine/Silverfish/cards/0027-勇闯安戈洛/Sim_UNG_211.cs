using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //* 荒蛮之主卡利莫斯 Kalimos, Primal Lord
    //[x]<b>Battlecry:</b> If you played anElemental last turn, cast anElemental Invocation.
    //<b>战吼：</b>如果你在上个回合使用过元素牌，则施放一个元素祈咒。 
    class Sim_UNG_211 : SimTemplate
    {



        // public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        // {
        //     if (p.anzOwnElementalsLastTurn > 0 && own.own) p.evaluatePenality -= 12;
        // }

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.UNG_211aa);
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (p.anzOwnElementalsLastTurn > 0 && own.own)
            {
                if (choice == 1)
                {
                    int MinionsCount = (own.own) ? p.ownMinions.Count : p.enemyMinions.Count;
                    p.callKid(kid, MinionsCount, own.own, false);
                    int kids = 6 - MinionsCount;
                    for (int i = 0; i < kids; i++)
                    {
                        p.callKid(kid, MinionsCount, own.own);
                    }
                }
                else if (choice == 2)
                {
                    int heal = (own.own) ? p.getSpellHeal(12) : p.getEnemySpellHeal(12);
                    p.minionGetDamageOrHeal(own.own ? p.ownHero : p.enemyHero, heal);
                }
                else if (choice == 3)
                {
                    int dmg = (own.own) ? p.getSpellDamageDamage(6) : p.getEnemySpellDamageDamage(6);
                    p.minionGetDamageOrHeal(own.own ? p.enemyHero : p.ownHero, dmg);
                }
                else if (choice == 4)
                {
                    int dmg = (own.own) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
                    p.allMinionOfASideGetDamage(!own.own, dmg);
                }


                /*
                另一只写法
                CardDB.cardIDEnum selectedCardID = CardDB.cardIDEnum.None;

                // 根据玩家选择的选项（choice）来决定添加哪张卡牌

                if (choice == 1)
                {
                    selectedCardID = CardDB.cardIDEnum.UNG_211a; // 土之祈咒
                }
                else if (choice == 2)
                {
                    selectedCardID = CardDB.cardIDEnum.UNG_211b; // 水之祈咒
                }
                else if (choice == 3)
                {
                    selectedCardID = CardDB.cardIDEnum.UNG_211c; // 火之祈咒
                }
                else if (choice == 4)
                {
                    selectedCardID = CardDB.cardIDEnum.UNG_211d; // 气之祈咒
                }
                CardDB.Card card = CardDB.Instance.getCardDataFromID(selectedCardID);
                card.sim_card.onCardPlay(p, ownplay, target, choice);
                */
            }

        }
    }
}