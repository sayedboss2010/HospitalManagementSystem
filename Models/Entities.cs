using System.ComponentModel.DataAnnotations;
namespace Hospital.Web.Models;
public abstract class BaseEntity { public int Id {get;set;} public bool IsActive {get;set;}=true; public DateTime CreatedAt {get;set;}=DateTime.UtcNow; }
public class Branch:BaseEntity {[Required,MaxLength(150)] public string Name {get;set;}=""; public string? Address {get;set;} public string? Phone {get;set;} }
public class Specialty:BaseEntity {[Required,MaxLength(150)] public string Name {get;set;}=""; }
public class Clinic:BaseEntity {[Required] public string Name {get;set;}=""; public string? RoomNumber {get;set;} public int BranchId {get;set;} public Branch? Branch {get;set;} }
public class Doctor:BaseEntity {[Required] public string Name {get;set;}=""; public int SpecialtyId {get;set;} public Specialty? Specialty {get;set;} public string? Phone {get;set;} }
public class MedicalService:BaseEntity {[Required] public string Name {get;set;}=""; [Range(0,double.MaxValue)] public decimal Price {get;set;} }
public class Patient:BaseEntity {[Required] public string FileNumber {get;set;}=""; [Required] public string FullName {get;set;}=""; public string? NationalId {get;set;} public string? Phone {get;set;} public DateOnly? BirthDate {get;set;} public string? Gender {get;set;} public string? Address {get;set;} }
