using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    //地标 萨满祭司 费用：3
    //Fairy Tale Forest
    //童话林地
    //[x]Draw a <b>Battlecry</b> minion.It costs (1) less.
    //抽一张<b>战吼</b>随从牌，其法力值消耗减少（1）点。
    class Sim_TOY_507 : SimTemplate
    {
        public override void useLocation(Playfield p, Minion triggerMinion, Minion target)
        {
            if (triggerMinion.handcard.card.CooldownTurn == 0)
            {
                // 遍历己方卡组，寻找具有战吼效果的随从牌
                foreach (CardDB.Card battlecryCard in p.ownDeck)
                {
                    CardDB.Card card = CardDB.Instance.getCardDataFromID(battlecryCard.cardIDenum);
                    if (card.type == CardDB.cardtype.MOB && card.battlecry)
                    {
                        card.cost--;
                        p.drawACard(battlecryCard.cardIDenum, true, true);
                        break;
                    }
                }
                
            }
        }

    }
}
