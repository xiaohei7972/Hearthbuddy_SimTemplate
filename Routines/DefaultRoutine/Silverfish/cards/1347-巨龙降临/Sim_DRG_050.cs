namespace HREngine.Bots
{
	class Sim_DRG_050 : SimTemplate //* 虔信狂徒 Devoted Maniac
	{
		//<b>Rush</b><b>Battlecry:</b> <b>Invoke</b> Galakrond.
		//<b>突袭，战吼：</b><b>祈求</b>迦拉克隆。
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DRG_238t14t3);
		CardDB.Card kid2 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DRG_238t12t2); 
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			//此处考虑到还没变身情况，所以不采用触发英雄技能的指令
			//采用判断职业之后直接释放技能的方式
			//之后如果有祈求接口可以再次修改优化，减少计算
			HeroEnum HeroName = p.ownHeroName;
			switch (HeroName)
			{
				case HeroEnum.priest: p.drawACard(CardDB.cardIDEnum.None, true, true); break;	//牧师
				case HeroEnum.thief: p.drawACard(CardDB.cardIDEnum.None, true, true); break;	//盗贼
				case HeroEnum.shaman:															//萨满
					{
						int pos =p.ownMinions.Count ;
						if(pos<=7)
							p.callKid(kid, pos, true);
					}
					break;															
				case HeroEnum.warrior: p.minionGetTempBuff(p.ownHero, 3, 0); break;			//战士
				case HeroEnum.warlock:

					int pos2 =  p.ownMinions.Count;
					if (pos2 < 6)
					{
						p.callKid(kid2, pos2, true);
						p.callKid(kid2, pos2+1, true);
					}
					else if(pos2 < 7 )
						p.callKid(kid2, pos2, true);
					break;
			}
			

		}


		}
	
}