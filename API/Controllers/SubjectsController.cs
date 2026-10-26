using System;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers;

public class SubjectsController(AppDbContext context) : BaseApiController
{
    [HttpGet]
    public async Task<ActionResult<List<Subject>>> GetSubjects()
    {
        return await context.Subjects.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Subject>> GetSubjectDetail(string id)
    {
        var subject = await context.Subjects.FindAsync(id);

        if (subject == null) return NotFound();

        return subject;
    }

}
