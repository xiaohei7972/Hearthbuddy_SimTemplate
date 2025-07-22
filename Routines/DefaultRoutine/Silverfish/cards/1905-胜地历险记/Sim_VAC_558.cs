using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 圣骑士 费用：10
	//Sea Shanty
	//海上船歌
	//Summon three 5/5 Pirates. Costs (1) less for each spell you've cast on characters this game.
	//召唤三个5/5的海盗。在本局对战中，你每对角色施放一个法术，本牌的法力值消耗便减少（1）点。
	class Sim_VAC_558 : SimTemplate
	{

        CardDB.Card pirate = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAC_558t); // 假设5/5海盗的卡牌ID为 VAC_558t

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            for (int i = 0; i < 3; i++)
            {
                int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
                if (pos < 7) // 确保场上有位置
                {
                    p.callKid(pirate, pos, ownplay); // 召唤一个5/5的海盗
                }
            }
        }
    }
}
