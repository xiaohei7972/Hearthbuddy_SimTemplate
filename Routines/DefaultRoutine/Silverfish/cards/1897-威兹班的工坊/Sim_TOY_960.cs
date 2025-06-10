using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：8 攻击力：6 生命值：6
	//Joymancer Jepetto
	//欢乐术师耶比托
	//[x]<b>Battlecry:</b> Get copies ofevery 1-Attack or 1-Healthminion you've playedthis game.
	//<b>战吼：</b>获取你在本局对战中使用过的每个生命值为1点或攻击力为1点的随从的各一张复制。
	class Sim_TOY_960 : SimTemplate
	{
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 遍历己方已使用的所有随从
            foreach (CardDB.cardIDEnum cardID in p.ownMinionsPlayedThisGame)
            {
                CardDB.Card card = CardDB.Instance.getCardDataFromID(cardID);

                // 检查是否是攻击力为1或生命值为1的随从
                if (card.Attack == 1 || card.Health == 1)
                {
                    // 将该随从的复制添加到手牌
                    p.drawACard(cardID, own.own, true);
                }
            }
        }

    }
}
