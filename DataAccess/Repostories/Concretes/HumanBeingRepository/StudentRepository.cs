﻿using DataAccess.Repostories.Abstracts.IHumanBeingREpositories;
using DBCodes.Entities.Concretes.HumanBeing;

namespace DataAccess.Repostories.Concretes.HumanBeingRepository;

public class StudentRepository : BaseRepository<Student>, IStudentRepository
{
}
