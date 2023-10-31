﻿using BusinessObject.Models;
using Microsoft.Extensions.Configuration;

namespace DataAccessObject
{
    public class MemberDAO
    {
        // Using Singleton Pattern
        private static MemberDAO instance = null;
        private static object instanceLook = new object();

        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLook)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }

        // Get default user from appsettings
        private Member GetDefaultMember()
        {
            Member Default = null;
            using (StreamReader r = new StreamReader("appsettings.json"))
            {
                string json = r.ReadToEnd();
                IConfiguration config = new ConfigurationBuilder()
                                        .SetBasePath(Directory.GetCurrentDirectory())
                                        .AddJsonFile("appsettings.json", true, true)
                                        .Build();
                string email = config["defaultAccount:email"];
                string password = config["defaultAccount:password"];
                Default = new Member
                {
                    MemberId = 0,
                    Email = email,
                    Password = password,
                    City = "",
                    Country = "",
                    CompanyName = ""
                };
            }
            return Default;
        }

        public IEnumerable<Member> GetMembersList()
        {
            IEnumerable<Member> members = null;

            try
            {
                var context = new SalesManagementContext();
                // Get From Database
                members = context.Members;
                // Add Default User
                members = members.Append(GetDefaultMember());

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return members;
        }

        public Member Login(string email, string password)
        {
            IEnumerable<Member> members = GetMembersList();
            Member member = members.SingleOrDefault(mb => mb.Email.Equals(email) && mb.Password.Equals(password));
            return member;
        }

        public Member GetMember(int memberId)
        {
            Member member = null;

            try
            {
                var context = new SalesManagementContext();
                member = context.Members.SingleOrDefault(mem => mem.MemberId == memberId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return member;
        }

        public Member GetMember(string memberEmail)
        {
            Member member = null;

            try
            {
                var context = new SalesManagementContext();
                member = context.Members.SingleOrDefault(mem => mem.Email.Equals(memberEmail));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return member;
        }

        public int GetNextMemberId()
        {
            int nextMemberId = -1;

            try
            {
                var context = new SalesManagementContext();
                nextMemberId = context.Members.Max(mem => mem.MemberId) + 1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return nextMemberId;
        }
        public void AddMember(Member member)
        {
            if (member == null)
            {
                throw new Exception("Member is undefined!!");
            }
            try
            {
                if (GetMember(member.MemberId) == null && GetMember(member.Email) == null)
                {
                    var context = new SalesManagementContext();
                    context.Members.Add(member);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Member is existed!!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Update(Member member)
        {
            if (member == null)
            {
                throw new Exception("Member is undefined!!");
            }
            try
            {
                Member _mem = GetMember(member.MemberId);
                if (_mem != null)
                {
                    var context = new SalesManagementContext();
                    context.Members.Update(member);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Member does not exist!!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public void Delete(int MemberId)
        {
            try
            {
                Member member = GetMember(MemberId);
                if (member != null)
                {
                    var context = new SalesManagementContext();
                    context.Members.Remove(member);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Member does not exist!!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public IEnumerable<Member> searchmemberbyId(string name)
        {
            IEnumerable<Member> searchresult = null;

            try
            {
                var context = new SalesManagementContext();
                searchresult = context.Members.Where(mem => mem.MemberId.ToString().Contains(name.ToLower()));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return searchresult;
        }

        public IEnumerable<Member> FilterMemberByCountry(string country, IEnumerable<Member> searchList = null)
        {
            IEnumerable<Member> searchResult = null;
            if (searchList != null)
            {
                var memberSearch = from member in searchList
                                   where member.Country == country
                                   select member;
                if (country.Equals("All"))
                {
                    memberSearch = from member in searchList
                                   select member;
                }
                searchResult = memberSearch;
            }
            else
            {
                var context = new SalesManagementContext();
            }

            return searchResult;
        }

        public IEnumerable<Member> FilterMemberByCity(string country, string city, IEnumerable<Member> searchList)
        {
            IEnumerable<Member> searchResult = null;
            var memberSearch = from member in searchList
                               where member.City == city
                               select member;
            if (city.Equals("All"))
            {
                memberSearch = from member in searchList
                               where member.Country == country
                               select member;
                if (country.Equals("All"))
                {
                    memberSearch = from member in searchList
                                   select member;
                }
            }
            searchResult = memberSearch;
            return searchResult;
        }

    }

}
