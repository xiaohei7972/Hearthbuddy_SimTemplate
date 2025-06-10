using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 萨满祭司 费用：3
	//Natural Talent
	//自然天性
	//Get a random Naga and a random spell. They cost (2) less.
	//随机获取纳迦牌和法术牌各一张，其法力值消耗减少（2）点。
	class Sim_VAC_329 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            // 随机获取一张纳迦牌
            p.drawACard(CardDB.cardIDEnum.None, ownplay);

            // 随机获取一张法术牌
            p.drawACard(CardDB.cardIDEnum.None, ownplay);

        }
    }
}
