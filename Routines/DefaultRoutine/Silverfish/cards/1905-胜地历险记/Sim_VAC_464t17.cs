using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 中立 费用：5
	//Staff of Scales
	//异鳞之杖
	//Summon three 1/1 Snakes with <b>Rush</b>, <b>Poisonous</b> and <b>Reborn</b>.
	//召唤三条1/1并具有<b>突袭，剧毒</b>和<b>复生</b>的蛇。
	class Sim_VAC_464t17 : SimTemplate
	{
        CardDB.Card snake = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ULDA_008t); // 预设的1/1蛇卡牌ID

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            for (int i = 0; i < 3; i++)
            {
                int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
                p.callKid(snake, pos, ownplay);
            }
        }

    }
}
